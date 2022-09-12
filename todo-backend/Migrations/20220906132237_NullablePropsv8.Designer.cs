﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using todo_backend.Models;

#nullable disable

namespace todo_backend.Migrations
{
    [DbContext(typeof(ListContext))]
    [Migration("20220906132237_NullablePropsv8")]
    partial class NullablePropsv8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("todo_backend.Models.SubTask", b =>
                {
                    b.Property<int>("SubTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SubComplete")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("SubCompletionTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("SubDeadline")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SubDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubDesc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SubName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TodoTaskId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SubTaskId");

                    b.HasIndex("TodoTaskId");

                    b.ToTable("SubTask");
                });

            modelBuilder.Entity("todo_backend.Models.TodoList", b =>
                {
                    b.Property<int>("TodoListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TodoListDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TodoListDesc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TodoListName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TodoListId");

                    b.ToTable("TodoList");
                });

            modelBuilder.Entity("todo_backend.Models.TodoTask", b =>
                {
                    b.Property<int>("TodoTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TaskComplete")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("TaskCompletionTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("TaskDeadline")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TaskDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaskDesc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TodoListId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TodoTaskId");

                    b.HasIndex("TodoListId");

                    b.ToTable("TodoTask");
                });

            modelBuilder.Entity("todo_backend.Models.SubTask", b =>
                {
                    b.HasOne("todo_backend.Models.TodoTask", null)
                        .WithMany("SubTasks")
                        .HasForeignKey("TodoTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("todo_backend.Models.TodoTask", b =>
                {
                    b.HasOne("todo_backend.Models.TodoList", null)
                        .WithMany("TodoTasks")
                        .HasForeignKey("TodoListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("todo_backend.Models.TodoList", b =>
                {
                    b.Navigation("TodoTasks");
                });

            modelBuilder.Entity("todo_backend.Models.TodoTask", b =>
                {
                    b.Navigation("SubTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
