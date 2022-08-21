import React from "react"
import Transacoes from "./Transacao"
import { render } from '@testing-library/react'

describe('Componente de lista de transações do extrato', () => {
    it('O snapshot do componente deve permanecer sempre o mesmo', () => {
        const listaDeTransacoes = [
            { id: 1, tipo: 'saque', valor: '20.00', data: '08/09/2020' },
            { id: 2, tipo: 'deposito', valor: '25.00', data: '08/10/2020' },
            { id: 3, tipo: 'saque', valor: '30.00', data: '10/09/2020' }
          ]
      
          const { container } = render(<Transacoes 
            transacoes={listaDeTransacoes}
          />)
      
          expect(container.firstChild).toMatchSnapshot();
    })
})