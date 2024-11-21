﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint
    //class referans tip
    //IEntity olabilir veya IEntity implemente eden bir nesne
    //new() : new lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null);  //Datayı filtreleyip getirmrk için(Delege)
        T Get(Expression<Func<T, bool>> filter);          //Tek detay getirmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
