using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagementSystem.Models {
  public class OrderItem {
    private double _amount;
    private double _price;

    public string OrderId { get; set; }
    [Required]
    public string Name { get; set; }

    [Required]
    public double Price {
      get => _price;
      set {
        if (value > 0) {
          _price = value;
        }
        else {
          throw new InvalidDataException("价格不能位负数");
        }
      }
    }

    [Required]
    public double Amount {
      get => _amount;
      set {
        if (value > 0) {
          _amount = value;
        }
        else {
          throw new InvalidDataException("数量不能为负数");
        }
      }
    }
  }
}
