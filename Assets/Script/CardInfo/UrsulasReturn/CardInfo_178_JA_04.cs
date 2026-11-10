using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_04 : CardInfo
{
    public CardInfo_178_JA_04()
    {
        this.cardNo = "178_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "É`ÉFÉìÅEÉ|Å[";
        this.cardName2 = "çcåRï∫ém";
        this.power = 4;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MichelaCacciatoreAndGiuliaPriori;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
