﻿using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.Application.Contracts.Professionals
{
    public interface IProfessionalsService
    {
        bool Add(Professional entity);

        bool Delete(Professional entity);

        Professional Update(Professional entity);

        Professional GetOne(long id);

        List<Professional> GetAll();
    }
}