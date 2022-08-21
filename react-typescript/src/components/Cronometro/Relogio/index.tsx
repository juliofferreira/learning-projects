import { SEGUNDOS_EM_UM_MINUTO } from '../../../common/constants';
import style from './Relogio.module.scss';

interface Props {
  tempo: number | undefined
}

export default function Relogio({ tempo = 0 }: Props) {
  const minutos = Math.floor(tempo / SEGUNDOS_EM_UM_MINUTO)
  const segundos = tempo % SEGUNDOS_EM_UM_MINUTO
  const [minutoDezena, minutoUnidade] = String(minutos).padStart(2, '0')
  const [segundoDezena, segundoUnidade] = String(segundos).padStart(2, '0')
  return (
    <>
      <span className={style.relogioNumero}>{minutoDezena}</span>
      <span className={style.relogioNumero}>{minutoUnidade}</span>
      <span className={style.relogioDivisao}>:</span>
      <span className={style.relogioNumero}>{segundoDezena}</span>
      <span className={style.relogioNumero}>{segundoUnidade}</span>
    </>
  )
}