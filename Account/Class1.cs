using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{

    public delegate void AccountHandler(string message);
    public delegate void Accounthand(string mmm);
    
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
        public void Add(int sum)
        {
            this.sum += sum;
            taken?.Invoke($"На счет пополнен на: {this.sum} у.е.");
        }
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
    public class xxx
    {
        public int mani;
        event Accounthand zo;
        
        public xxx(int s)
        {
            this.mani = s;
        }

        public void RegHandler(Accounthand del)
        {
            zo += del;
        }

        public void Ad(int sum)
        {
            this.mani += mani;
            zo?.Invoke($"На счет пополнен на: {this.mani} у.е.");
        }
        public void Ta(int sum)
        {
            if (this.mani >= sum)
            {
                this.mani -= mani;
                zo?.Invoke($"Со счета списано {mani} у.е.");
            }
            else
                zo?.Invoke ($"Недостаточно средств. Баланс: {this.mani} у.е.");
        }

    }
}
