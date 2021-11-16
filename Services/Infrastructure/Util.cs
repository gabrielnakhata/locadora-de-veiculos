namespace Services.Infrastructure
{
    public static class Util
    {
        public static string RetLetraAlfabeto(int i)
        {
            return i switch
            {
                1 => "A",
                2 => "B",
                3 => "C",
                4 => "D",
                5 => "E",
                6 => "F",
                7 => "G",
                8 => "H",
                9 => "I",
                10 => "J",
                11 => "K",
                12 => "L",
                13 => "M",
                14 => "N",
                15 => "O",
                16 => "P",
                17 => "Q",
                18 => "R",
                19 => "S",
                20 => "T",
                21 => "U",
                22 => "V",
                23 => "X",
                24 => "Y",
                25 => "W",
                26 => "Z",
                _ => "$",
            };
        }
    }
}
