namespace Ejercicio_01.Automata;

class Automata_01
{
    private State state;
    private string buffer;
    private List<string> values;
    private readonly char[] alphabet = new char[] { '0', '1', 'a', 'b' };

    public List<string> Match(string input)
    {
        values = new();
        buffer = "";
        state = State.A;
        for (int i = 0; i < input.Length; i++)
        {
            char value = input[i];
            ChangeState(value);
            if (state == State.Out)
            {
                IfBuffer();
                state = State.A;
                if(alphabet.Contains(value))
                {
                    ChangeState(value);
                    buffer += value;
                }
                
            }
            else {
                buffer += value;
            }
        }
        IfBuffer();
        return values;
    }

    private void ChangeState(char value)
    {
        switch (state)
            {
                case State.A:
                    if(value == '0')
                    {
                        state = State.B;
                    }
                    else if(value == '1')
                    {
                        state = State.C;
                    }
                    else if(value == 'a')
                    {
                        state = State.D;
                    }
                    else if(value == 'b')
                    {
                        state = State.E;
                    }
                    else {
                        state = State.Out;
                    }
                    break;

                case State.B:
                case State.C:
                    if(value == '0')
                    {
                        state = State.B;
                    }
                    else if(value == '1')
                    {
                        state = State.C;
                    }
                    else if(value == 'b')
                    {
                        state = State.E;
                    }
                    else state = State.Out;
                    break;

                case State.D:
                case State.E:
                    if(value == 'b')
                    {
                        state = State.E;
                    }
                    else state = State.Out;
                    break;

                default:
                    state = State.Out;
                    break;
            }
    }
    
    private void IfBuffer()
    {
        if (buffer.Length > 0)
        {
            values.Add(buffer);
            buffer = "";
        }
    }

}

public enum State
{
    A,
    B,
    C,
    D,
    E,
    Out
}