import { SEGUNDOS_EM_UMA_HORA, SEGUNDOS_EM_UM_MINUTO } from "../constants"

export function tempoParaSegundos(tempo: string): number {
    const [horas = '0', minutos = '0', segundos = '0'] = tempo.split(":")

    const horasEmSegundos = Number(horas) * SEGUNDOS_EM_UMA_HORA
    const minutosEmSegundos = Number(minutos) * SEGUNDOS_EM_UM_MINUTO

    return horasEmSegundos + minutosEmSegundos + Number(segundos)
}