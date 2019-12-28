using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria_EECC_App
{
    class Estado
    {
        private int anio;
        private string nombreE;
        private double activocte;
        private double activonocte;
        private double bncambio;
        private double pasivocte;
        private double pasivonocte;
        private double patneto;
        private double rtdoneto;
        private double venta;
        private double rtoord;


        public int pAnio
        {
            set { anio = value; }
            get { return anio; }
        }

        public string pNombreE
        {
            set { nombreE = value; }
            get { return nombreE; }
        }

        public double pActivoCte
        {
            set { activocte = value; }
            get { return activocte; }
        }
        public double pActivoNoCte
        {
            set { activonocte = value; }
            get { return activonocte; }
        }
        public double pBnCambio
        {
            set { bncambio = value; }
            get { return bncambio; }
        }
        public double pPasivoCte
        {
            set { pasivocte = value; }
            get { return pasivocte; }
        }
        public double pPasivoNoCte
        {
            set { pasivonocte = value; }
            get { return pasivonocte; }
        }
        public double pPatNeto
        {
            set { patneto = value; }
            get { return patneto; }
        }
        public double pRtdoNeto
        {
            set { rtdoneto = value; }
            get { return rtdoneto; }
        }
        public double pVenta
        {
            set { venta = value; }
            get { return venta; }
        }
        public double pRtdoOrd
        {
            set { rtoord = value; }
            get { return rtoord; }
        }

        public Estado()
        {
            this.activocte = 0;
            this.activonocte = 0;
            this.pasivocte = 0;
            this.pasivonocte = 0;
            this.patneto = 0;
            this.rtoord = 0;
            this.rtdoneto = 0;
            this.venta = 0;
        }


        public string toStringMessage()
        {
            return "**DATOS CARGADOS CORRECTAMENTE**";
        }
        public string toStringEstados()
        {
            return "*DATOS CARGADOS CORRECTAMENTE*"+"\nEMPRESA: " +nombreE +"\nAÑO EJERCICIO: " +anio.ToString()+ "\nTOTAL ACTIVO: " 
                +calcularTotalActivo().ToString() + "\nTOTAL PASIVO: " +calcularTotalPasivo().ToString() 
                +"\nTOTAL PATRIMONIO NETO: " + patneto.ToString() + "\nRESULTADO NETO: " +rtdoneto.ToString();
        }

        public double calcularTotalActivo()
        {
            double activoT;
            activoT = Math.Round((activocte + activonocte), 2);
            return activoT;
        }

        public double calcularTotalPasivo()
        {
            double pasivoT;
            pasivoT = Math.Round((pasivocte + pasivonocte),2);
            return pasivoT;
        }

        public double calcularSolvencia()
        {
            double solvencia;
            solvencia = Math.Round((patneto / (calcularTotalPasivo())),2);
            return solvencia;
        }

        public double calcularEndeudamiento()
        {
            double endeudamiento;
            endeudamiento = Math.Round(((calcularTotalPasivo()/patneto)), 2);
            return endeudamiento;
        }

        public double calcularLiquidezCte()
        {
            double liquiCte;
            liquiCte = Math.Round((activocte / pasivocte), 2);
            return liquiCte;
        }

        public double calcularPruebaAcida()
        {
            double pruebaA;
            pruebaA = Math.Round(((activocte-bncambio)/pasivocte),2);
            return pruebaA;
        }

        public double calcularRznPNAct()
        {
            double razonPNA;
            razonPNA = Math.Round((patneto / calcularTotalActivo()), 2);
            return razonPNA;
        }
        public double calcularRznInmAct()
        {
            double razonInmAct;
            razonInmAct = Math.Round((activonocte / calcularTotalActivo()), 2);
            return razonInmAct;
        
        }
        public double calcularRtbInvAcc()
        {
            double rtbInvAcc;
            rtbInvAcc = Math.Round((rtdoneto / patneto), 2);
            return rtbInvAcc;
        }

        public double calcularApalancaFin()
        {
            double apalancaFin;
            apalancaFin = Math.Round(((rtoord/patneto)/(rtoord/calcularTotalActivo())),2);
            return apalancaFin;
        }

        public double calcularRotacionAct()
        {
            double rotAct;
            rotAct = Math.Round((venta / calcularTotalActivo()), 2);
            return rotAct;
        }




    }


    }
