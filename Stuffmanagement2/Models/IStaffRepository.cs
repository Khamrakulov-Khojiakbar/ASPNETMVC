﻿namespace Stuffmanagement2.Models
{
    public interface IStaffRepository
    {
        Staff Get(int id);
        
        IEnumerable<Staff> GetAll();
    }
}
