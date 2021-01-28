﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TreasureRoom.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TreasureRoomEntities : DbContext
    {
        public TreasureRoomEntities()
            : base("name=TreasureRoomEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dbo_ItemTypes> dbo_ItemTypes { get; set; }
        public virtual DbSet<dbo_Titles> dbo_Titles { get; set; }
        public virtual DbSet<dbo_Questions_Electronic> dbo_Questions_Electronic { get; set; }
        public virtual DbSet<dbo_Questions_FashionAccessory> dbo_Questions_FashionAccessory { get; set; }
        public virtual DbSet<dbo_Questions_Keys> dbo_Questions_Keys { get; set; }
        public virtual DbSet<dbo_Questions_WalletOrPurse> dbo_Questions_WalletOrPurse { get; set; }
        public virtual DbSet<dbo_RetrieveItemsUsers> dbo_RetrieveItemsUsers { get; set; }
        public virtual DbSet<dbo_LostItems> dbo_LostItems { get; set; }
    
        public virtual ObjectResult<Get_LostItems_Result> Get_LostItems()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_LostItems_Result>("Get_LostItems");
        }
    
        public virtual ObjectResult<Get_ItemTypes_Result> Get_ItemTypes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_ItemTypes_Result>("Get_ItemTypes");
        }
    
        public virtual int Post_RetrieveItemsUsers(string iD, string fullName, string emailAddress, string phoneNumber)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var fullNameParameter = fullName != null ?
                new ObjectParameter("FullName", fullName) :
                new ObjectParameter("FullName", typeof(string));
    
            var emailAddressParameter = emailAddress != null ?
                new ObjectParameter("EmailAddress", emailAddress) :
                new ObjectParameter("EmailAddress", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Post_RetrieveItemsUsers", iDParameter, fullNameParameter, emailAddressParameter, phoneNumberParameter);
        }
    
        public virtual int Post_LostItems(string iD, string editID, string title, string description, string postcode, string itemType, string imagePath, Nullable<System.DateTime> datePosted, string userTitle, string userFullName, string userEmailAddress, string question1, string answer1, string question2, string answer2, string question3, string answer3)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var editIDParameter = editID != null ?
                new ObjectParameter("EditID", editID) :
                new ObjectParameter("EditID", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var postcodeParameter = postcode != null ?
                new ObjectParameter("Postcode", postcode) :
                new ObjectParameter("Postcode", typeof(string));
    
            var itemTypeParameter = itemType != null ?
                new ObjectParameter("ItemType", itemType) :
                new ObjectParameter("ItemType", typeof(string));
    
            var imagePathParameter = imagePath != null ?
                new ObjectParameter("ImagePath", imagePath) :
                new ObjectParameter("ImagePath", typeof(string));
    
            var datePostedParameter = datePosted.HasValue ?
                new ObjectParameter("DatePosted", datePosted) :
                new ObjectParameter("DatePosted", typeof(System.DateTime));
    
            var userTitleParameter = userTitle != null ?
                new ObjectParameter("UserTitle", userTitle) :
                new ObjectParameter("UserTitle", typeof(string));
    
            var userFullNameParameter = userFullName != null ?
                new ObjectParameter("UserFullName", userFullName) :
                new ObjectParameter("UserFullName", typeof(string));
    
            var userEmailAddressParameter = userEmailAddress != null ?
                new ObjectParameter("UserEmailAddress", userEmailAddress) :
                new ObjectParameter("UserEmailAddress", typeof(string));
    
            var question1Parameter = question1 != null ?
                new ObjectParameter("Question1", question1) :
                new ObjectParameter("Question1", typeof(string));
    
            var answer1Parameter = answer1 != null ?
                new ObjectParameter("Answer1", answer1) :
                new ObjectParameter("Answer1", typeof(string));
    
            var question2Parameter = question2 != null ?
                new ObjectParameter("Question2", question2) :
                new ObjectParameter("Question2", typeof(string));
    
            var answer2Parameter = answer2 != null ?
                new ObjectParameter("Answer2", answer2) :
                new ObjectParameter("Answer2", typeof(string));
    
            var question3Parameter = question3 != null ?
                new ObjectParameter("Question3", question3) :
                new ObjectParameter("Question3", typeof(string));
    
            var answer3Parameter = answer3 != null ?
                new ObjectParameter("Answer3", answer3) :
                new ObjectParameter("Answer3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Post_LostItems", iDParameter, editIDParameter, titleParameter, descriptionParameter, postcodeParameter, itemTypeParameter, imagePathParameter, datePostedParameter, userTitleParameter, userFullNameParameter, userEmailAddressParameter, question1Parameter, answer1Parameter, question2Parameter, answer2Parameter, question3Parameter, answer3Parameter);
        }
    }
}
