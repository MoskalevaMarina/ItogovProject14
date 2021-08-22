// <copyright file="Contact.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProject14
{
    /// <summary>
    /// Класс Contact
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="name">Ввод имени</param>
        /// <param name="lastName">Ввод фамилии</param>
        /// <param name="phoneNumber">Ввод номера телефона</param>
        /// <param name="email">Ввод email</param>
        public Contact(string name, string lastName, long phoneNumber, string email)
        {
            this.Name = name;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        /// <summary>
        /// Gets a value indicating whether поле для хранения имени
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения фамилии
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения номера телефона
        /// </summary>
        public long PhoneNumber { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения email
        /// </summary>
        public string Email { get; }
    }
}
