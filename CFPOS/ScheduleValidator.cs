using FluentValidation;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CFPOS
{
    public class ScheduleValidator : AbstractValidator<Schedule>
    {
        public ScheduleValidator() 
        {
            RuleFor(Schedule => Schedule.TimeStart.Value)
                .NotEmpty().WithMessage("Please enter time start")
                .Must(validateTime).WithMessage("Time must be within 24 hours of a day");
            RuleFor(Schedule => Schedule.TimeEnd.Value)
                .NotEmpty().WithMessage("Please enter time end")
                .Must(validateTime).WithMessage("Time must be within 24 hours of a day");
            RuleFor(Schedule => Schedule.Date)
                .NotEmpty().WithMessage("Please enter date");
            RuleFor(Schedule => Schedule.Status)
                .NotEmpty().WithMessage("Please specify the status");
            RuleFor(Schedule => new { Schedule.TimeStart, Schedule.TimeEnd })
                .Must(Schedule => validateTimeStartAndEnd(Schedule.TimeStart.Value, Schedule.TimeEnd.Value))
                .WithMessage("Time Start must be greater than time end");
        }

        private bool validateTime(int time)
        {
            bool check = true;
            if(time < 0 || time > 24)
            {
                check = false;
            }
            return check;

        }

        private bool validateTimeStartAndEnd(int timeStart, int timeEnd)
        {
            bool check = false;
            if (timeStart < timeEnd) { 
                check = true;
            }
            return check;
        }
    }
}
