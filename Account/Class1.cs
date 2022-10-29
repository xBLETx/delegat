using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{

    public delegate void AccountHandler(string message);
    public class AccountCl
    {
        int sum;
        string fio;
        AccountHandler taken;
        public AccountCl(int sum,string fio)
        {
            this.sum = sum;
            this.fio = fio;
        }
        // Регистрируем делегат
        public void RegisterHandler(AccountHandler del)
        {
            taken += del;
        }
        // Отмена регистрации делегата
        public void UnregisterHandler(AccountHandler del)
        {
            taken -= del; // удаляем делегат
        }
        public void Add(int sum) => this.sum += sum;
        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                taken?.Invoke($"Со счета списано {sum} у.е.");
            }
            else
                taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
        }
    }
}
