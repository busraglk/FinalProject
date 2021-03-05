using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key); //generic olmayan versiyonu. Bu şekilde de yazılabilir.
        void Add(string key, object value,int duration);

        bool IsAdd(string key); //cache de var mı? diye kontrol ederiz.
        void Remove(string key); //cache uçurma.
        void RemoveByPattern(string pattern); //hangi key'i vereceğimizi bilmediğimiz zamanlarda  kullancağız. İsmi Get ile başlayanları uçur,isminde Category olanları uçur gibi. bir tane pattern veririz.Farklı farklı kullanım senaryolarını burada yapıyor olacağız.
    }
}
