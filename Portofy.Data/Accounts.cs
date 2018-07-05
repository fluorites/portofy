using System;
using System.Collections.Generic;
using System.Text;

//  Создание пространства имен Онуфрия Токарева.
namespace Onuphrius {
    // Создание пространства имен счетов
    namespace Portofy.Data.Account {

        /// <summary>Абстрактный счёт инвестиций.</summary>
        public abstract class CAccount {
            /// <summary>Имя счёта.</summary>
            protected string m_sName;
            /// <summary>Признак активности счёта.</summary>
            protected bool m_bActive;

            /// <summary>Создание объекта.</summary>
            /// <param name="x_sName">имя счёта</param>
            /// <param name="x_bActive">если true, то счёт активен</param>
            public CAccount(string x_sName, bool x_bActive) {
                m_sName = x_sName;
                m_bActive = x_bActive;
            }
        }

        /// <summary>Счёт инвестиций в банковский вклад.</summary>
        public class CDepositAccount: CAccount {
            /// <summary>Создание объекта.</summary>
            /// <param name="x_sName">имя счёта</param>
            /// <param name="x_bActive">если true, то счёт активен</param>
            public CDepositAccount(string x_sName, bool x_bActive): base(x_sName,x_bActive) {
            }
        }

        /// <summary>Счёт инвестиций в валюту.</summary>
        public class CCurrencyAccount : CAccount {
            /// <summary>Создание объекта.</summary>
            /// <param name="x_sName">имя счёта</param>
            /// <param name="x_bActive">если true, то счёт активен</param>
            public CCurrencyAccount(string x_sName, bool x_bActive) : base(x_sName, x_bActive) {
            }
        }

        /// <summary>Счёт инвестиций в акции.</summary>
        public class CStockAccount : CAccount {
            /// <summary>Создание объекта.</summary>
            /// <param name="x_sName">имя счёта</param>
            /// <param name="x_bActive">если true, то счёт активен</param>
            public CStockAccount(string x_sName, bool x_bActive) : base(x_sName, x_bActive) {
            }
        }

        /// <summary>Счёт инвестиций в облигации.</summary>
        public class CBondAccount : CAccount {
            /// <summary>Создание объекта.</summary>
            /// <param name="x_sName">имя счёта</param>
            /// <param name="x_bActive">если true, то счёт активен</param>
            public CBondAccount(string x_sName, bool x_bActive) : base(x_sName, x_bActive) {
            }
        }
    }
}
