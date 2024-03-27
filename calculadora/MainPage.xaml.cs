namespace calculadora;

public partial class MainPage : ContentPage
{
    int count = 0;
    string cadena = " ";
    string cadenaAux = " ";
    double first = 0;
    double second = 0;
    string operador = " ";
    double operacion;

    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

    

	private void Uno(object sender, EventArgs e)
	{

        count++;

        if (count == 1) {
            cadena = "1";
            second = Double.Parse(cadena);
            resultado.Text = cadena;
        }else if(operador == "+" || operador == "-" || operador == "x" || operador == "÷")
        {
            
            cadenaAux = cadena + "1";
            cadena = cadenaAux;
            second = double.Parse(cadena);
            resultado.Text = cadenaAux;
        }
        else
        {

            string cadenaAux = cadena + "1";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
        }
    }

    private void Dos(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
        {
            cadena = "2";
            resultado.Text = cadena;
        }
        else if (operador == "+" || operador == "-" || operador == "x" || operador == "÷" )
        {

            cadenaAux = cadena + "2";
            cadena = cadenaAux;
            second = double.Parse(cadena);
            resultado.Text = cadenaAux;
        }
        else
        {

            string cadenaAux = cadena + "2";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
        }
    }

    private void Tres(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
        {
            cadena = "3";
            resultado.Text = cadena;
        }
        else if (operador == "+" || operador == "-" || operador == "x" || operador == "÷")
        {

            cadenaAux = cadena + "3";
            cadena = cadenaAux;
            second = double.Parse(cadena);
            resultado.Text = cadenaAux;
        }
        else
        {

            string cadenaAux = cadena + "3";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
        }
    }

    

    private void Cuatro(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = "4";
            resultado.Text = cadena;
        }
        else if (operador == "+" || operador == "-" || operador == "x" || operador == "÷")
        {

            cadenaAux = cadena + "4";
            cadena = cadenaAux;
            second = double.Parse(cadena);
            resultado.Text = cadenaAux;
        }
        else
        {

            string cadenaAux = cadena + "4";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
        }
    }

    private void Cinco(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = "5";
            resultado.Text = cadena;
        }
        else if (operador == "+" || operador == "-" || operador == "x" || operador == "÷")
        {

            cadenaAux = cadena + "5";
            cadena = cadenaAux;
            second = double.Parse(cadena);
            resultado.Text = cadenaAux;
        }
        else
        {

            string cadenaAux = cadena + "5";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
        }
    }

    private void Seis(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = "6";
            resultado.Text = cadena;
        }
        else if (operador == "+" || operador == "-" || operador == "x" || operador == "÷")
        {

            cadenaAux = cadena + "6";
            cadena = cadenaAux;
            second = double.Parse(cadena);
            resultado.Text = cadenaAux;
        }
        else
        {

            string cadenaAux = cadena + "6";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
        }
    }

    

    private void Siete(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = "7";
            resultado.Text = cadena;
        }
        else if (operador == "+" || operador == "-" || operador == "x" || operador == "÷")
        {

            cadenaAux = cadena + "7";
            cadena = cadenaAux;
            second = double.Parse(cadena);
            resultado.Text = cadenaAux;
        }
        else
        {

            string cadenaAux = cadena + "7";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
        }
    }

    private void Ocho(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = "8";
            resultado.Text = cadena;
        }
        else if (operador == "+" || operador == "-" || operador == "x" || operador == "÷")
        {

            cadenaAux = cadena + "8";
            cadena = cadenaAux;
            second = double.Parse(cadena);
            resultado.Text = cadenaAux;
        }
        else
        {

            string cadenaAux = cadena + "8";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
        }
    }

    private void Nueve(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = "9";
            resultado.Text = cadena;
        }else if(operador == "+" || operador == "-" || operador == "x" || operador == "÷")
        {
            
            cadenaAux = cadena + "9";
            cadena = cadenaAux;
            second = double.Parse(cadena);
            resultado.Text = cadenaAux;
        }
        else
        {

            cadenaAux = cadena + "9";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
        }
    }

    private void Cero(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = "0";
            resultado.Text = cadena;
        }
        else if (operador == "+" || operador == "-" || operador == "x" || operador == "÷")
        {

            cadenaAux = cadena + "0";
            cadena = cadenaAux;
            second = double.Parse(cadena);
            resultado.Text = cadenaAux;
        }
        else
        {
             
            string cadenaAux = cadena + "0";
            cadena = cadenaAux;
            second = Double.Parse(cadenaAux);
            resultado.Text = cadenaAux;
        }
    }



    private void Punto(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = ".";
            resultado.Text = cadena;
        }
        else
        {

            string cadenaAux = cadena + ".";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
        }
    }

    private void Clear(object sender, EventArgs e)
    {
        cadena = " ";
        cadenaAux = " ";
        resultado.Text = cadena;
        resultado.Text = cadenaAux;

    }

    

    private void Suma(object sender, EventArgs e)
    {

        count++;
        if (count == 1)
        {
            cadena = "+";
            operador = "+";
            resultado.Text = cadena;
        }
        else
        {
            first = Double.Parse(cadena);
            operador = "+";
            cadenaAux = cadena + "+";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
            cadena = "";
            cadenaAux = "";

        }

    }


    private void Resta(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = "-";
            operador = "-";
            resultado.Text = cadena;
        }
        else
        {
            first = Double.Parse(cadena);
            operador = "-";
            cadenaAux = cadena + "-";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
            cadena = "";
            cadenaAux = "";
        }
    }

    private void Dividir(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = "÷";
            operador = "÷";
            resultado.Text = cadena;
        }
        else
        {

            first = Double.Parse(cadena);
            operador = "÷";
            cadenaAux = cadena + "÷";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
            cadena = "";
            cadenaAux = "";
        }
    }

    private void Multiplicar(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
        {
            cadena = "x";
            operador = "x";
            resultado.Text = cadena;
        }
        else
        {
            first = Double.Parse(cadena);
            operador = "x";
            cadenaAux = cadena + "x";
            cadena = cadenaAux;
            resultado.Text = cadenaAux;
            cadena = "";
            cadenaAux = "";
        }
    }

    private void Calcular(object sender, EventArgs e)
    {
        if (operador == "+")
        {
            operacion = first + second;
        }else if (operador == "-")
        {
            operacion = first - second;
        }
        else if (operador == "x")
        {
            operacion = first * second;
        }
        else if (operador == "÷")
        {
            operacion = first / second;
        }
        

        string resultadoFinal = operacion.ToString();
        resultado.Text = "Resultado: " + resultadoFinal;
        count = 0;


    }
}

