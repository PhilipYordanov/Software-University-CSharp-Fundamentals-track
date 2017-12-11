using FastFood.Data;
using FastFood.DataProcessor.Dto.Import;
using FastFood.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FastFood.DataProcessor
{
    public static class Deserializer
    {
        private const string FailureMessage = "Invalid data format.";
        private const string SuccessMessage = "Record {0} successfully imported.";

        public static string ImportEmployees(FastFoodDbContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var deserializedEmployees = JsonConvert.DeserializeObject<EmployeeDTO[]>(jsonString);
            var validEmployees = new List<Employee>();
            var employeesPositions = new List<Position>();

            foreach (EmployeeDTO employeeDTO in deserializedEmployees)
            {
                if (!IsValid(employeeDTO))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var currentPosition = new Position
                {
                    Name = employeeDTO.Position
                };

                if (!employeesPositions.Any(x => x.Name == employeeDTO.Position))
                {
                    employeesPositions.Add(currentPosition);
                }

                var currentEmployee = new Employee
                {
                    Name = employeeDTO.Name,
                    Age = employeeDTO.Age,
                    Position = employeesPositions.FirstOrDefault(x => x.Name == employeeDTO.Position)
                };

                validEmployees.Add(currentEmployee);
                sb.AppendLine($"Record {currentEmployee.Name} successfully imported.");
            }

            context.Employees.AddRange(validEmployees);
            context.SaveChanges();
            var result = sb.ToString();

            return result;
        }

        public static string ImportItems(FastFoodDbContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var deserializedItems = JsonConvert.DeserializeObject<ItemDTO[]>(jsonString);
            var validItems = new List<Item>();
            var categories = new List<Category>();

            foreach (ItemDTO itemDTO in deserializedItems)
            {
                if (!IsValid(itemDTO))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                if (validItems.Any(x => x.Name == itemDTO.Name))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var currentCategory = new Category
                {
                    Name = itemDTO.Category
                };

                if (!categories.Any(x => x.Name == itemDTO.Category))
                {
                    categories.Add(currentCategory);
                }

                var currentItem = new Item
                {
                    Name = itemDTO.Name,
                    Price = itemDTO.Price,
                    Category = categories.FirstOrDefault(x => x.Name == itemDTO.Category)
                };

                validItems.Add(currentItem);
                sb.AppendLine($"Record {currentItem.Name} successfully imported.");
            };

            context.Items.AddRange(validItems);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportOrders(FastFoodDbContext ctx, string xmlString)
        {
            var sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(OrderDTO[]), new XmlRootAttribute("Orders"));
            var deserializedOrders = (OrderDTO[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

            var validOrders = new List<Order>();

            foreach (var orderDTO in deserializedOrders)
            {
                if (!IsValid(orderDTO))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var listOfOrders = new List<OrderItem>();
                foreach (OrderItemDTO value in orderDTO.Item)
                {
                    var currentOrderItem = new OrderItem()
                    {
                        Item = ctx
                            .Items
                            .FirstOrDefault(x => x.Name == value.Name),
                        Quantity = value.Quantity
                    };
                    listOfOrders.Add(currentOrderItem);
                }

                var currentOrder = new Order
                {
                    Customer = orderDTO.Customer,
                    Employee = ctx.Employees.FirstOrDefault(x => x.Name == orderDTO.Employee),
                    DateTime = DateTime.ParseExact(orderDTO.DateTime, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                    Type = orderDTO.Type,
                    OrderItems = listOfOrders
                };

                sb.AppendLine($"Order for {orderDTO.Customer} on {orderDTO.DateTime} added");

                validOrders.Add(currentOrder);
            }

            ctx.Orders.AddRange(validOrders);
            ctx.SaveChanges();

            string result = sb.ToString();
            return result;
        }

        private static bool IsValid(object obj)
        {
            ValidationContext validationContext = new ValidationContext(obj);
            List<ValidationResult> validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
            return isValid;
        }
    }
}