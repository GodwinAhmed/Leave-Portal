using AutoMapper;
using Leave_Portal.Data;
using Leave_Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Portal.Mappings
{
    public class Maps : Profile 
    {
        public Maps ()
        {
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
