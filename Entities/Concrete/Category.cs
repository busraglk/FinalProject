using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın standardı. Bu varlıkları
    //işareleme eğilimine gideriz. Bu şudur concreteki sınıflar çıplak kalmasın diye abstract de interface(IEntity) oluşturduk. 
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
