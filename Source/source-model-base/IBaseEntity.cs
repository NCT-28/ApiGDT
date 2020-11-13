namespace Source.source_model_base
{
    interface IBaseEntity<T> : IAuditEntity<string>
    {
        T getUuid();
    }
}