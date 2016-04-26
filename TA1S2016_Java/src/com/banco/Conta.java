/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.banco;

import java.util.Date;

/**
 *
 * @author Antonio Lopes
 */
public class Conta {

    String numero;
    String nome;
    Date dataAbertura;
    private double limite;
    private double saldo;

    Conta() {
        this.numero = "";
        this.nome = "";
        this.dataAbertura = new Date();
        this.limite = 0.0;
        this.saldo = 0.0;
    }
    
    Conta(double limite) {
        this();
        this.limite = limite;
    }
    
    Conta(double limite, double saldo) {
        this(limite);
        this.saldo = saldo;
    }
    
    Conta(String nome, double limite, double saldo) {
        this(limite, saldo);
        this.nome = nome;
    }
    
    public String getNumero() {
        return this.numero;
    }

    public void setNumero(String numero) {
        this.numero = numero;
    }

    public String getNome() {
        return this.nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public Date getDataAbertura() {
        return this.dataAbertura;
    }

    public void setDataAbertura(Date dataAbertura) {
        this.dataAbertura = dataAbertura;
    }

    public void setLimite(double limite) {
        this.limite = limite;
    }

    public double getSaldo() {
        return this.saldo + this.limite;
    }

    boolean saca(double valor) {

        if (valor > (this.saldo + this.limite)) {
            return false;
        } else {
            double novoSaldo = this.saldo - valor;
            this.saldo = novoSaldo;
            return true;
        }
    }

    void deposita(double valor) {
        double novoSaldo = this.saldo + valor;
        this.saldo = novoSaldo;
    }

    void transfere(Conta destino, double valor) {
        destino.saldo = destino.saldo + valor;
        this.saldo = this.saldo - valor;
    }
}