﻿using MediatR;

namespace Cqrs.CQRS.Commands
{
    public class RemoveStudentCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveStudentCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
