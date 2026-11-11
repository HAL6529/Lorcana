using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_05 : CardInfo
{
    public CardInfo_178_JA_05()
    {
        this.cardNo = "178_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉNÉçÉìÉN";
        this.cardName2 = "ñ≥ñ∆ãñÇÃîÈñßë{ç∏äØ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger1 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
