using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint - generic kısıt
    //class : referans tip olabilir.
    //where T:class,IEntity --> T bir referans tip olmalı ve T, ya IEntity olabilir ya da IEntity implemente eden bir nesne olabilir.
    //new() --> new'lenebilir olmalı. IEntity new'lenemediği için biz IEntity kullanamayız.IEntity soyut bir nesnedir.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
