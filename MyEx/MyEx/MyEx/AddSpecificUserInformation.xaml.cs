using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSpecificUserInformation : ContentPage
    {
        public AddSpecificUserInformation()
        {
            InitializeComponent();
            CountryItems();
        }


        private void CountryItems()
        {
            Country.Items.Add("Albania");
            Country.Items.Add("Alemania");
            Country.Items.Add("Andorra");
            Country.Items.Add("Angola");
            Country.Items.Add("Antigua y Barbuda");
            Country.Items.Add("Arabia Saudita");
            Country.Items.Add("Argelia");
            Country.Items.Add("Argentina");
            Country.Items.Add("Armenia");
            Country.Items.Add("Australia");
            Country.Items.Add("Austria");
            Country.Items.Add("Azerbaiyán");
            Country.Items.Add("Bahamas");
            Country.Items.Add("Bahrein");
            Country.Items.Add("Bangladesh");
            Country.Items.Add("Barbados");
            Country.Items.Add("Belarús");
            Country.Items.Add("Belice");
            Country.Items.Add("Benin");
            Country.Items.Add("Bhután");
            Country.Items.Add("Bolivia");
            Country.Items.Add("Bosnia");
            Country.Items.Add("Botswana");
            Country.Items.Add("Brasil");
            Country.Items.Add("Brunei Darussalam");
            Country.Items.Add("Bulgaria");
            Country.Items.Add("Burkina Faso");
            Country.Items.Add("Burundi");
            Country.Items.Add("Bélgica");
            Country.Items.Add("Cabo Verde");
            Country.Items.Add("Camboya");
            Country.Items.Add("Camerún");
            Country.Items.Add("Canadá");
            Country.Items.Add("Chad");
            Country.Items.Add("Chequia");
            Country.Items.Add("Chile");
            Country.Items.Add("China");
            Country.Items.Add("Chipre");
            Country.Items.Add("Colombia");
            Country.Items.Add("Comoras");
            Country.Items.Add("Congo");
            Country.Items.Add("Costa Rica");
            Country.Items.Add("Croacia");
            Country.Items.Add("Cuba");
            Country.Items.Add("Dinamarca");
            Country.Items.Add("Djibouti");
            Country.Items.Add("Dominica");
            Country.Items.Add("Ecuador");
            Country.Items.Add("Egipto");
            Country.Items.Add("El Salvador");
            Country.Items.Add("Emiratos Árabes Unidos");
            Country.Items.Add("Eritrea");
            Country.Items.Add("Eslovaquia");
            Country.Items.Add("Eslovenia");
            Country.Items.Add("España");
            Country.Items.Add("Estados Unidos de América");
            Country.Items.Add("Estonia");
            Country.Items.Add("Eswatini");
            Country.Items.Add("Etiopía");
            Country.Items.Add("Federación Rusia");
            Country.Items.Add("Fiji");
            Country.Items.Add("Filipinas");
            Country.Items.Add("Finlandia");
            Country.Items.Add("Francia");
            Country.Items.Add("Gabón");
            Country.Items.Add("Gambia");
            Country.Items.Add("Gerorgia");
            Country.Items.Add("Ghana");
            Country.Items.Add("Granada");
            Country.Items.Add("Grecia");
            Country.Items.Add("Guatemala");
            Country.Items.Add("Guinea");
            Country.Items.Add("Guinea Ecuatorial");
            Country.Items.Add("Guyana");
            Country.Items.Add("Haití");
            Country.Items.Add("Honduras");
            Country.Items.Add("Hungría");
            Country.Items.Add("India");
            Country.Items.Add("Indonesia");
            Country.Items.Add("Iraq");
            Country.Items.Add("Irlanda");
            Country.Items.Add("Irán");
            Country.Items.Add("Islandia");
            Country.Items.Add("Islas Cook");
            Country.Items.Add("Islas Feroe");
            Country.Items.Add("Islas Marshall");
            Country.Items.Add("Islas Salomón");
            Country.Items.Add("Israel");
            Country.Items.Add("Italia");
            Country.Items.Add("Jamaica");
            Country.Items.Add("Japón");
            Country.Items.Add("Jordania");
            Country.Items.Add("Kazajstán");
            Country.Items.Add("Kenya");
            Country.Items.Add("Kirguistán");
            Country.Items.Add("Kiribati");
            Country.Items.Add("Kuwait");
            Country.Items.Add("Lesotho");
            Country.Items.Add("Letonia");
            Country.Items.Add("Liberia");
            Country.Items.Add("Libia");
            Country.Items.Add("Lituania");
            Country.Items.Add("Luxemburgo");
            Country.Items.Add("Líbano");
            Country.Items.Add("Macedonia del Norte");
            Country.Items.Add("Madagascar");
            Country.Items.Add("Malasia");
            Country.Items.Add("Malawi");
            Country.Items.Add("Maldivas");
            Country.Items.Add("Malta");
            Country.Items.Add("Malí");
            Country.Items.Add("Marruecos");
            Country.Items.Add("Mauricio");
            Country.Items.Add("Mauritania");
            Country.Items.Add("Micronesia");
            Country.Items.Add("Mongolia");
            Country.Items.Add("Montenegro");
            Country.Items.Add("Mozambique");
            Country.Items.Add("Myanmar");
            Country.Items.Add("México");
            Country.Items.Add("Mónaco");
            Country.Items.Add("Namibia");
            Country.Items.Add("Nauru");
            Country.Items.Add("Nepal");
            Country.Items.Add("Nicaragua");
            Country.Items.Add("Níger");
            Country.Items.Add("Omán");
            Country.Items.Add("Pakistán");
            Country.Items.Add("Palau");
            Country.Items.Add("Panamá");
            Country.Items.Add("Papua Nueva Guinea");
            Country.Items.Add("Paraguay");
            Country.Items.Add("Países Bajos");
            Country.Items.Add("Perú");
            Country.Items.Add("Polonia");
            Country.Items.Add("Portugal");
            Country.Items.Add("Qatar");
            Country.Items.Add("Reino Unido");
            Country.Items.Add("República Democrática del Congo");
            Country.Items.Add("República de Corea");
            Country.Items.Add("Rumania");
            Country.Items.Add("Samoa");
            Country.Items.Add("Santa Lucia");
            Country.Items.Add("Senegal");
            Country.Items.Add("Serbia");
            Country.Items.Add("Singapur");
            Country.Items.Add("Somalia");
            Country.Items.Add("Sudáfrica");
            Country.Items.Add("Sudán");
            Country.Items.Add("Sudán del sur");
            Country.Items.Add("Suecia");
            Country.Items.Add("Suiza");
            Country.Items.Add("Tailandia");
            Country.Items.Add("Togo");
            Country.Items.Add("Turquía");
            Country.Items.Add("Ucrania");
            Country.Items.Add("Uganda");
            Country.Items.Add("Uruguay");
            Country.Items.Add("Venezuela");
            Country.Items.Add("Viet Nam");
            Country.Items.Add("Yemen");
            Country.Items.Add("Zambia");
            Country.Items.Add("Zimbabwe");
           

        }//end

        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            state.IsEnabled = false;
            state.Items.Clear();


            if(Country.SelectedItem.Equals("México"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Aguascalientes");
                state.Items.Add("Baja California");
                state.Items.Add("Baja California Sur");
                state.Items.Add("Campeche");
                state.Items.Add("Chiapas");
                state.Items.Add("Chihuahua");
                state.Items.Add("Ciudad de México");
                state.Items.Add("Coahuila");
                state.Items.Add("Colima");
                state.Items.Add("Durango");
                state.Items.Add("Estado de México");
                state.Items.Add("Guanajuato");
                state.Items.Add("Guerrero");
                state.Items.Add("Hidalgo");
                state.Items.Add("Jalisco");
                state.Items.Add("Michoacán");
                state.Items.Add("Morelos");
                state.Items.Add("Nayarit");
                state.Items.Add("Nuevo León");
                state.Items.Add("Oaxaca");
                state.Items.Add("Puebla");
                state.Items.Add("Querétaro");
                state.Items.Add("Quintana Roo");
                state.Items.Add("San Luis Potosí");
                state.Items.Add("Sinaloa");
                state.Items.Add("Sonora");
                state.Items.Add("Tabasco");
                state.Items.Add("Tamaulipas");
                state.Items.Add("Tlaxcala");
                state.Items.Add("Veracruz");
                state.Items.Add("Yucatán");
                state.Items.Add("Zacatecas");
            }//end ifMexico

            if (Country.SelectedItem.Equals("Estados Unidos de América"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Alabama");
                state.Items.Add("Alaska");
                state.Items.Add("Arizona");
                state.Items.Add("Arkansas");
                state.Items.Add("California");
                state.Items.Add("Colorado");
                state.Items.Add("Connecticut");
                state.Items.Add("Delaware");
                state.Items.Add("Florida");
                state.Items.Add("Georgia");
                state.Items.Add("Hawaii");
                state.Items.Add("Idaho");
                state.Items.Add("Illinois");
                state.Items.Add("Indiana");
                state.Items.Add("Iowa");
                state.Items.Add("Kansas");
                state.Items.Add("Kentucky");
                state.Items.Add("Louisiana");
                state.Items.Add("Maine");
                state.Items.Add("Maryland");
                state.Items.Add("Massachusetts");
                state.Items.Add("Michigan");
                state.Items.Add("Minnesota");
                state.Items.Add("Mississippi");
                state.Items.Add("Missouri");
                state.Items.Add("Montana");
                state.Items.Add("Nebraska");
                state.Items.Add("Nevada");
                state.Items.Add("New Hampshire");
                state.Items.Add("New Jersey");
                state.Items.Add("New Mexico");
                state.Items.Add("New York");
                state.Items.Add("North Carolina");
                state.Items.Add("Ohio");
                state.Items.Add("Oklahoma");
                state.Items.Add("Oregon");
                state.Items.Add("Pennsylvania");
                state.Items.Add("Rhode Island");
                state.Items.Add("South California");
                state.Items.Add("South Dakota");
                state.Items.Add("Tennessee");
                state.Items.Add("Texas");
                state.Items.Add("Utah");
                state.Items.Add("Vermont");
                state.Items.Add("Virginia");
                state.Items.Add("Washington");
                state.Items.Add("West Virginia");
                state.Items.Add("Wisconsin");
                state.Items.Add("Wyoming");
                
            }//end If USA


            if (Country.SelectedItem.Equals("Canadá"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Ontario");
                state.Items.Add("Quebec");
                state.Items.Add("Nova Scotia");
                state.Items.Add("New Brunswick");
                state.Items.Add("Manitoba");
                state.Items.Add("British Columbia");
                state.Items.Add("Prince Edward Island");
                state.Items.Add("Saskatchewan");
                state.Items.Add("Alberta");
                state.Items.Add("Newfoundland and Labrador");

            }//end Canada


            if (Country.SelectedItem.Equals("Argentina"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Andina");
                state.Items.Add("Buenos Aires");
                state.Items.Add("Capital Federal");
                state.Items.Add("Catamarca");
                state.Items.Add("Centro");
                state.Items.Add("Chaco");
                state.Items.Add("Chubut");
                state.Items.Add("Córdoba");
                state.Items.Add("Corrientes");
                state.Items.Add("Entre Ríos");
                state.Items.Add("Formosa");
                state.Items.Add("Jujuy");
                state.Items.Add("La Pampa");
                state.Items.Add("La Rioja");
                state.Items.Add("Litoral");
                state.Items.Add("Mendoza");
                state.Items.Add("Misiones");
                state.Items.Add("Neuquén");
                state.Items.Add("Norte");
                state.Items.Add("Patagonia");
                state.Items.Add("Río Negro");
                state.Items.Add("Saltan");
                state.Items.Add("San Juan");
                state.Items.Add("San Luis");
                state.Items.Add("Santa Cruz");
                state.Items.Add("Santa Fe");
                state.Items.Add("Santiago del Estero");
                state.Items.Add("Tierra del Fuego");
                state.Items.Add("Tucumán");

            }//end if Argentina

            if (Country.SelectedItem.Equals("Brasil"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Acre");
                state.Items.Add("Alagoas");
                state.Items.Add("Amapá");
                state.Items.Add("Amazonas");
                state.Items.Add("Bahia");
                state.Items.Add("Ceará");
                state.Items.Add("Distrito Federal");
                state.Items.Add("Espírito Santo");
                state.Items.Add("Goiás");
                state.Items.Add("Maranhao");
                state.Items.Add("Mato Grosso");
                state.Items.Add("Mato Grosso do Sul");
                state.Items.Add("Minas Gerais");
                state.Items.Add("Pará");
                state.Items.Add("Paraíba");
                state.Items.Add("Paraná");
                state.Items.Add("Pernambuco");
                state.Items.Add("Piauí");
                state.Items.Add("Rio de Janeiro");
                state.Items.Add("Rio Grande do Norte");
                state.Items.Add("Rio Grande do Sul");
                state.Items.Add("Rondonia");
                state.Items.Add("Roraima");
                state.Items.Add("Santa Catarina");
                state.Items.Add("Sao Paulo");
                state.Items.Add("Sergipe");
                state.Items.Add("Tocantins");

            }//end Brasil

            if (Country.SelectedItem.Equals("Colombia"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Amazonas");
                state.Items.Add("Antioquia");
                state.Items.Add("Arauca");
                state.Items.Add("Atlántico");
                state.Items.Add("Bogotá");
                state.Items.Add("Bolívar");
                state.Items.Add("Boyacá");
                state.Items.Add("Caldas");
                state.Items.Add("Caquetá");
                state.Items.Add("Casanare");
                state.Items.Add("Cauca");
                state.Items.Add("Cesar");
                state.Items.Add("Chocó");
                state.Items.Add("Córdoba");
                state.Items.Add("Cundinamarca");
                state.Items.Add("Guainía");
                state.Items.Add("Guaviare");
                state.Items.Add("Huila");
                state.Items.Add("La Guajira");
                state.Items.Add("Magdalena");
                state.Items.Add("Meta");
                state.Items.Add("Nariño");
                state.Items.Add("Norte de Santander");
                state.Items.Add("Putomayo");
                state.Items.Add("Quindío");
                state.Items.Add("Risaralda");
                state.Items.Add("San Andrés y Providencia");
                state.Items.Add("Santander");
                state.Items.Add("Sucre");
                state.Items.Add("Tolima");
                state.Items.Add("Valle del Cauca");
                state.Items.Add("Vaupés");
                state.Items.Add("Vichada");
                
            }//end Colombia

            if (Country.SelectedItem.Equals("Perú"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Amazonas");
                state.Items.Add("Ancash");
                state.Items.Add("Apurímac");
                state.Items.Add("Arequipa");
                state.Items.Add("Ayacucho");
                state.Items.Add("Cajamarca");
                state.Items.Add("Cuzco");
                state.Items.Add("Huancavelica");
                state.Items.Add("Huánuco");
                state.Items.Add("Ica");
                state.Items.Add("Junín");
                state.Items.Add("La Libertad");
                state.Items.Add("Lambayeque");
                state.Items.Add("Lima");
                state.Items.Add("Loreto");
                state.Items.Add("Madre de Dios");
                state.Items.Add("Moquegua");
                state.Items.Add("Pasco");
                state.Items.Add("Piura");
                state.Items.Add("Puno");
                state.Items.Add("San Martin");
                state.Items.Add("Tacna");
                state.Items.Add("Tumbes");
                state.Items.Add("Ucayali");

            }//end peru

            if (Country.SelectedItem.Equals("Venezuela"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Amazonas");
                state.Items.Add("Anzoátegui");
                state.Items.Add("Apure");
                state.Items.Add("Aragua");
                state.Items.Add("Barinas");
                state.Items.Add("Bolívar");
                state.Items.Add("Carabobo");
                state.Items.Add("Cojedes");
                state.Items.Add("Delta Amacuro");
                state.Items.Add("Falcón");
                state.Items.Add("Guárico");
                state.Items.Add("La Guaira");
                state.Items.Add("Lara");
                state.Items.Add("Mérida");
                state.Items.Add("Miranda");
                state.Items.Add("Monagas");
                state.Items.Add("Nueva Esparta");
                state.Items.Add("Portuguesa");
                state.Items.Add("Sucre");
                state.Items.Add("Táchira");
                state.Items.Add("Trujillo");
                state.Items.Add("Yaracuy");
                state.Items.Add("Zulia");
                

            }//end venezuela

            if (Country.SelectedItem.Equals("Chile"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Arica and Parinacota");
                state.Items.Add("Tarapacá");
                state.Items.Add("Antofagasta");
                state.Items.Add("Atacama");
                state.Items.Add("Coquimbo");
                state.Items.Add("Valparaíso");
                state.Items.Add("Metropolitan");
                state.Items.Add("O´Higgins");
                state.Items.Add("Maule");
                state.Items.Add("Ñuble");
                state.Items.Add("Biobío");
                state.Items.Add("Araucanía");
                state.Items.Add("Los Ríos");
                state.Items.Add("Los Lagos");
                state.Items.Add("Aysén");
                state.Items.Add("Magallanes");
                

            }//end chile

            if (Country.SelectedItem.Equals("Guatemala"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Alta Verapaz");
                state.Items.Add("Baja Verapaz");
                state.Items.Add("Chimaltenango");
                state.Items.Add("Chiquimula");
                state.Items.Add("El Progreso");
                state.Items.Add("Escuintla");
                state.Items.Add("Guatemala");
                state.Items.Add("Huehuetenango");
                state.Items.Add("Izabal");
                state.Items.Add("Jalapa");
                state.Items.Add("Jutiapa");
                state.Items.Add("Petén");
                state.Items.Add("Quetzaltenango");
                state.Items.Add("Quiché");
                state.Items.Add("Retalhuleu");
                state.Items.Add("Sacatepéquez");
                state.Items.Add("San Marcos");
                state.Items.Add("Santa Rosa");
                state.Items.Add("Sololá");
                state.Items.Add("Suchitepéquez");
                state.Items.Add("Totonicapán");
                state.Items.Add("Zacapa");
                

            }//end Guatemala

            if (Country.SelectedItem.Equals("Ecuador"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Azuay");
                state.Items.Add("Bolívar");
                state.Items.Add("Cañar");
                state.Items.Add("Carchi");
                state.Items.Add("Chimborazo");
                state.Items.Add("Cotopaxi");
                state.Items.Add("El Oro");
                state.Items.Add("Esmeraldas");
                state.Items.Add("Galápagos");
                state.Items.Add("Guayas");
                state.Items.Add("Imbabura");
                state.Items.Add("Loja");
                state.Items.Add("Los Ríos");
                state.Items.Add("Manabí");
                state.Items.Add("Morona Santiago");
                state.Items.Add("Napo");
                state.Items.Add("Orellana");
                state.Items.Add("Pastaza");
                state.Items.Add("Pichincha");
                state.Items.Add("Santa Elena");
                state.Items.Add("Santo Domingo de los Tsáchilas");
                state.Items.Add("Sucumbíos");
                state.Items.Add("Tungurahua");
                state.Items.Add("Zamora Chinchipe");

            }//end Guatemala

            if (Country.SelectedItem.Equals("Bolivia"))
            {
                state.IsEnabled = true;
                state.Items.Clear();
                state.Items.Add("Beni");
                state.Items.Add("Chuquisaca");
                state.Items.Add("Cochabamba");
                state.Items.Add("La Paz");
                state.Items.Add("Oruro");
                state.Items.Add("Pando");
                state.Items.Add("Potosí");
                state.Items.Add("Santa Cruz");
                state.Items.Add("Tarija");

            }//end Bolivia


            ////////////////////////////////////////////////
        }//end Country_SelectedIndex




    }//end class
}