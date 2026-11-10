using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_183_JA_04 : CardInfo
{
    public CardInfo_183_JA_04()
    {
        this.cardNo = "183_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉäÉì";
        this.cardName2 = "çcåRï∫ém";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MichelaCacciatoreAndGiuliaPriori;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
