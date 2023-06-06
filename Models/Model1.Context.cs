﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnglishCenter.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MinhcenterEntities : DbContext
    {
        public MinhcenterEntities()
            : base("name=MinhcenterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<user_cart> user_cart { get; set; }
        public virtual DbSet<user_wait> user_wait { get; set; }
        public virtual DbSet<user> users { get; set; }
    
        [DbFunction("MinhcenterEntities", "ShowCart")]
        public virtual IQueryable<ShowCart_Result> ShowCart(Nullable<int> us_id)
        {
            var us_idParameter = us_id.HasValue ?
                new ObjectParameter("us_id", us_id) :
                new ObjectParameter("us_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ShowCart_Result>("[MinhcenterEntities].[ShowCart](@us_id)", us_idParameter);
        }
    
        public virtual int addCart(string co_id, Nullable<int> us_id)
        {
            var co_idParameter = co_id != null ?
                new ObjectParameter("co_id", co_id) :
                new ObjectParameter("co_id", typeof(string));
    
            var us_idParameter = us_id.HasValue ?
                new ObjectParameter("us_id", us_id) :
                new ObjectParameter("us_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addCart", co_idParameter, us_idParameter);
        }
    
        public virtual int AddToOrder(Nullable<int> orderID, Nullable<int> us_id, Nullable<int> totalPrice)
        {
            var orderIDParameter = orderID.HasValue ?
                new ObjectParameter("orderID", orderID) :
                new ObjectParameter("orderID", typeof(int));
    
            var us_idParameter = us_id.HasValue ?
                new ObjectParameter("us_id", us_id) :
                new ObjectParameter("us_id", typeof(int));
    
            var totalPriceParameter = totalPrice.HasValue ?
                new ObjectParameter("totalPrice", totalPrice) :
                new ObjectParameter("totalPrice", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddToOrder", orderIDParameter, us_idParameter, totalPriceParameter);
        }
    
        public virtual int DeleteCourseInCart(string co_id, Nullable<int> us_id)
        {
            var co_idParameter = co_id != null ?
                new ObjectParameter("co_id", co_id) :
                new ObjectParameter("co_id", typeof(string));
    
            var us_idParameter = us_id.HasValue ?
                new ObjectParameter("us_id", us_id) :
                new ObjectParameter("us_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCourseInCart", co_idParameter, us_idParameter);
        }
    
        public virtual ObjectResult<getCourseFromCart_Result> getCourseFromCart(Nullable<int> us_id)
        {
            var us_idParameter = us_id.HasValue ?
                new ObjectParameter("us_id", us_id) :
                new ObjectParameter("us_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCourseFromCart_Result>("getCourseFromCart", us_idParameter);
        }
    
        public virtual ObjectResult<getCoursesJoined_Result> getCoursesJoined(Nullable<int> us_id)
        {
            var us_idParameter = us_id.HasValue ?
                new ObjectParameter("us_id", us_id) :
                new ObjectParameter("us_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCoursesJoined_Result>("getCoursesJoined", us_idParameter);
        }
    
        public virtual ObjectResult<getCoursesUnconfirm_Result> getCoursesUnconfirm()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCoursesUnconfirm_Result>("getCoursesUnconfirm");
        }
    
        public virtual ObjectResult<searchCourse_Result> searchCourse(string filter)
        {
            var filterParameter = filter != null ?
                new ObjectParameter("filter", filter) :
                new ObjectParameter("filter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<searchCourse_Result>("searchCourse", filterParameter);
        }
    }
}