using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_08 : CardInfo
{
    public CardInfo_141_JA_08()
    {
        this.cardNo = "141_JA_08";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ムーラン";
        this.cardName2 = "全速前進";
        this.power = 3;
        this.toughness = 3;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.GonzaloKenny;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
