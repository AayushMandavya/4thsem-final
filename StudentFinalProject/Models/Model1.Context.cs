﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace StudentFinalProject.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class firstEntities : DbContext
{
    public firstEntities()
        : base("name=firstEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<batch> batches { get; set; }

    public virtual DbSet<course> courses { get; set; }

    public virtual DbSet<registration> registrations { get; set; }

    public virtual DbSet<user> users { get; set; }

    public virtual DbSet<teacher> teachers { get; set; }

    public virtual DbSet<teacher1> teacher1 { get; set; }

}

}

