using DAL;
using MongoDB.Bson;
using MongoProject.Model;
using System.Collections.Generic;

namespace Logic
{
    public class Databases
    {
        private DAO dao;
        public Databases()
        {
            dao = new DAO();
        }

        public void AddTicket(Ticket ticket)
        {
            dao.AddTicket(ticket);
        }

        public List<Employee> GetEmployees()
        {
            return dao.GetAllEmployees();
        }

        public List<Ticket> GetTickets()
        {
            return dao.GetAllTickets();
        }

        public Ticket GetTicketById(ObjectId id)
        {
            return dao.GetTicketByID(id);
        }

        public Employee GetEmployeeById(ObjectId id)
        {
            return dao.GetEmployeeById(id);
        }

        public List<Ticket> GetTicketsByEmployeeId(Employee employee)
        {
            return dao.GetTicketsByEmployeeId(employee.Id);
        }

        public int GetTicketCount(Employee employee)
        {
            List<Ticket> tickets = GetTicketsByEmployeeId(employee);
            return tickets.Count;
        }

        public List<Ticket> GetListOfTickets()
        {
            return dao.GetAllTickets();
        }

        public void UpdateTicket(Ticket ticket)
        {
            dao.UpdateTicket(ticket);
        }

        public void DeleteTicket(Ticket ticket)
        {
            dao.DeleteTicket(ticket);
        }

        public void RetireTicket(Ticket ticket)
        {
            ticket.Status = TicketStatus.Closed;
            dao.RetireTicket(ticket);
        }   

    }
}
