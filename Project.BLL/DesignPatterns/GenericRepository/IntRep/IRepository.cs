using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T:BaseEntity
    {
        //List Commands

        List<T> GetAll();
        T GetById(int id);
        List<T> GetActives(); //Sadece Inserted ve Updated verileri getiren metot
        List<T> GetPassives(); //Sadece Passive verileri getiren metot
        List<T> GetModifieds(); //Sadece Updated verileri getiren metot

        //Modifications
        void Add(T entity);
        void Update(T entity);
        void MakePassive(T entity);
        void Delete(T entity);

        //Linq Expressions
        List<T> Where(Expression<Func<T,bool>> exp);
        bool Any(Expression<Func<T,bool>> exp);
        T FirstOrDefault(Expression<Func<T,bool>> exp);


        object Select(Expression<Func<T, dynamic>> exp);
        List<X> Select<X>(Expression<Func<T,X>> exp);

        
        //Expression dedigimiz yapılar, cagrıldıkları yerde fark edersiniz ki iki kısımdan olusurlar
        // _db.Categories.Where( x => x.CategoryName == "Beverages")

        //1. Argüman kısmıdır :   x =>   Delegate'te  ( Func kısmındaki T sayesinde belirlenir)
        //2. Beyan/Declaration/Request/Ultimatom kısmıdır  :   x.CategoryName == "Beverages"  (Func kısmındaki bool sayesinde belirledigimiz) Biz nasıl tip belirlerseyk öyle belirlenir


        //_db.Categories.Select<CategoryVM>(x => new CategoryVM)
        //1. Argüman kısmı : x =>    T   
        // 2. Beyan kısmı : new CategoryVM{} 


        



        
      
    }
}
