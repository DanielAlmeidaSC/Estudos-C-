namespace ClasseImutavel
{
    public class ChaveSeguranca
    {
        private int _id;
        private int _nivel;

        public ChaveSeguranca(int id, int nivel)
        {
            _id = id;
            _nivel = nivel;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not ChaveSeguranca novaChave)
            {
                return false;
            }

            return _id.Equals(novaChave._id) && _nivel.Equals(novaChave._nivel);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id, _nivel);
        }

        public override string ToString()
        {
            return $"ID: {_id} Nível: {_nivel}";
        }
    }
}