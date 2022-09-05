﻿using Microsoft.EntityFrameworkCore;

namespace todo_backend.Models
{
    public class TodoList
    {
        public int TodoListId { get; set; }
        public string TodoListName { get; set; }
        public string TodoListDesc { get; set; }
        public bool TodoListDeleted { get; set; }

        public int ListsId { get; set; }
        public Lists Lists { get; set; }
    }
}
