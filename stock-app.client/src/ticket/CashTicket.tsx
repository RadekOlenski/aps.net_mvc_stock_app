import React, {useEffect, useState} from "react";

export function CashTicket() {

    const [currencies, setCurrencies] = useState<string[]>([]);

    useEffect(() => {
        console.log('>>> request currencies');
        // TODO tutaj sobie robie HTTP request do backendu zeby pobrac rzeczy

        setTimeout(() => {
            const items = ['dog', 'cat', 'kura'];
            setCurrencies(items);
        }, 2000);
    }, []);


    return <div>
        <Header currencies={currencies}></Header>
        <Prices></Prices>
        <div>
            Amount
        </div>
    </div>
}

function Header({currencies}: Readonly<{ currencies: string[] }>) {
    const handleSelectCurrency = (event: {
        currentTarget: { value: string; };
    }) => console.log('>>>' + event.currentTarget.value);

    return <select onChange={handleSelectCurrency}>
        {currencies.map(item => <option key={item}>{item}</option>)}
    </select>
}

function Prices() {

    const startingBid = 1.111122;
    const [bid, setBid]: [number, (value: number) => void] = useState(startingBid);
    const [ask, setAsk]: [number, (value: number) => void] = useState(1.321122);

    useEffect(() => {
            setInterval(() => {
                const newBid = startingBid + Math.random() * 0.1;
                const bidAsString = newBid.toFixed(6);
                const bidAsNumber = Number(bidAsString);
                setBid(bidAsNumber);
            }, 500)
        }
    );

    return <div>
        <span className='price'>{bid}</span>
        <span className='price'>{ask}</span>
    </div>
}

/*

type Price = {
    major: numberl
    minor: number;
    pips: number;
}


1.234 67 1


 */
