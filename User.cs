using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWork
{
    internal class User
    {
        string name, surname, patronymic, login;
        bool chClient, chCount, chSeller, chGoods, chGoodsInvoice, chAccounts, chInvoice, needUpdate = false;
        string accessClient, accessCount, accessSeller, accessGoods, accessGoodsInvoice, accessAccounts, accessInvoice;

        public User(string name, string surname, string patronymic, string login, bool chClient, bool chCount, bool chSeller, bool chGoods, bool chGoodsInvoice, bool chAccounts, bool chInvoice, string accessClient, string accessCount, string accessSeller, string accessGoods, string accessGoodsInvoice, string accessAccounts, string accessInvoice)
        {
            this.name = name; // Имя пользователя
            this.surname = surname; // Фамилия пользователя
            this.patronymic = patronymic; // Отчество пользователя
            this.login = login; // Логин пользователя
            this.chClient = chClient; // Права на таблицу Client
            this.chCount = chCount; // Права на таблицу Count
            this.chSeller = chSeller; // Права на таблицу Seller
            this.chGoods = chGoods; // Права на таблицу Goods
            this.chGoodsInvoice = chGoodsInvoice; // Права на таблицу GoodsInvoice
            this.chAccounts = chAccounts; // Права на таблицу logins
            this.chInvoice = chInvoice; // Права на таблицу Invoice
            this.accessClient = accessClient; // Доступ к таблице Client 
            this.accessCount = accessCount; // Доступ к таблице Count
            this.accessSeller = accessSeller; // Доступ к таблице Seller
            this.accessGoods = accessGoods; // Доступ к таблице Goods
            this.accessGoodsInvoice = accessGoodsInvoice; // Доступ к таблице GoodsInvoice
            this.accessAccounts = accessAccounts; // Доступ к таблице logins
            this.accessInvoice = accessInvoice; // Доступ к таблице Invoice
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public string Login { get => login; set => login = value; }
        public bool ChClient { get => chClient; set => chClient = value; }
        public bool ChCount { get => chCount; set => chCount = value; }
        public bool ChSeller { get => chSeller; set => chSeller = value; }
        public bool ChGoods { get => chGoods; set => chGoods = value; }
        public bool ChGoodsInvoice { get => chGoodsInvoice; set => chGoodsInvoice = value; }
        public bool ChAccounts { get => chAccounts; set => chAccounts = value; }
        public bool ChInvoice { get => chInvoice; set => chInvoice = value; }
        public string AccessClient { get => accessClient; set => accessClient = value; }
        public string AccessCount { get => accessCount; set => accessCount = value; }
        public string AccessSeller { get => accessSeller; set => accessSeller = value; }
        public string AccessGoods { get => accessGoods; set => accessGoods = value; }
        public string AccessGoodsInvoice { get => accessGoodsInvoice; set => accessGoodsInvoice = value; }
        public string AccessAccounts { get => accessAccounts; set => accessAccounts = value; }
        public string AccessInvoice { get => accessInvoice; set => accessInvoice = value; }
        public bool NeedUpdate { get => needUpdate; set => needUpdate = value; }
    }
}
