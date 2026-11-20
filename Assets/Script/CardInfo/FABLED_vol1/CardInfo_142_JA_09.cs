using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_09 : CardInfo
{
    public CardInfo_142_JA_09()
    {
        this.cardNo = "142_JA_09";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ムーラン";
        this.cardName2 = "思慮深い使節";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LadyShalirin;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
