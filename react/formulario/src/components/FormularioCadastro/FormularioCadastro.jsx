import { Step, StepLabel, Stepper, Typography } from '@material-ui/core';
import { useEffect, useState } from 'react';
import DadosEntrega from './DadosEntrega';
import DadosPessoais from './DadosPessoais';
import DadosUsuario from './DadosUsuário';

function FormularioCadastro({ onSubmit, validacoes }) {
  const [etapaAtual, setEtapaAtual] = useState(0);
  const [dadosColetados, setDados] = useState({});

  useEffect(() => {
    if (etapaAtual === formularios.length) {
      onSubmit(dadosColetados);
    } 
  });

  const formularios = [
    <DadosUsuario onSubmit={coletarDados} />,
    <DadosPessoais onSubmit={coletarDados} />,
    <DadosEntrega onSubmit={coletarDados} />,
    <Typography variant='h5'>Obrigado pelo cadastro!</Typography>
  ];

  function coletarDados(dados) {
    setDados({ ...dadosColetados, ...dados });
    console.log(dadosColetados);
    proximo();
  }

  function proximo(dados) {
    setEtapaAtual(etapaAtual + 1);
  }


  return (
    <>
      <Stepper activeStep={etapaAtual}>
        <Step><StepLabel>Login</StepLabel></Step>
        <Step><StepLabel>Pessoal</StepLabel></Step>
        <Step><StepLabel>Entrega</StepLabel></Step>
        <Step><StepLabel>Finalização</StepLabel></Step>
      </Stepper>
      {formularios[etapaAtual]}
    </>
  );
}

export default FormularioCadastro;
