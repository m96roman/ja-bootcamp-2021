﻿namespace Task3
{
    public interface IWorker
    {
        decimal Salary { get; }

        void DecreaseSalary(decimal amount);

        void IncreaseSalary(decimal diff);

        void FullName();

        object GetFullName();
    }
}