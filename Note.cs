using System;
using System.Collections.Generic;
using System.Linq;
/*Класс Note (Телефонный справочник) – содержит коллекцию объектов класса
Contact, экземпляры которого представляют записи в телефонном справочнике. В
числе полей класса Contact должны присутствовать: название контакта (фамилия,
имя, отчество или ник для человека, название для организации или службы), один
или более номеров телефона, название группы. Предусмотреть возможность
выполнения следующих операций: просмотр и редактирование справочника и
отдельных записей, создания и просмотра групп, поиска по имени контакта.*/
class Contact
{
    
    public string name { get; set; }
    public string org { get; set; }
    public string number { get; set; }
    public string group { get; set; }


    public Contact(string n, string Org, string numb, string gr )
    {

        name = n;
        org = Org;
        number = numb;
        group = gr;
        
        //IsSold = false;
    }
}

class Note
{
    private List<Contact> contacts;

    public Note()
    {
        contacts = new List<Contact>();
    }

    public void AddContact(string n, string Org, string numb, string gr)
    {
        contacts.Add(new Contact(n, Org, numb,  gr));

    
    }
    public void DeleteContact(string n, string Org, string numb, string gr)
    {
        var removeValue =contacts.First(x => x.name == n && x.org == Org && x.number == numb && x.group == gr);
        contacts.Remove(removeValue);

    }

    public void  RedactContact(string n, string Org, string numb, string gr, string n1, string Org1, string numb1, string gr1)
    {
        var redactValue = contacts.First(x => x.name == n && x.org == Org && x.number == numb && x.group == gr);
        contacts.Remove(redactValue);
        contacts.Add(new Contact(n1, Org1, numb1, gr1));


    }
    public void Addgr(string n,  string gr)
    {
        var redactValue = contacts.First(x => x.name == n );
        redactValue.group = gr;
    }
    public List<Contact> FindGr( string gr)
    {
        return contacts.Where(t => t.group == gr).ToList();
    }
    
    public List<Contact> FindContact(string n)
    {
        return contacts.Where(t =>  t.name == n ).ToList();
    }

    
}
