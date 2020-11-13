namespace  Source.source_model_base
{
    interface INaturalIdEntity<T> : IBaseEntity<T>
    {
        string getCode();
        void setCode(string code);
    }
}