using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_09 : CardInfo
{
    public CardInfo_173_JA_09()
    {
        this.cardNo = "173_JA_09";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ナラ";
        this.cardName2 = "不屈のメスライオン";
        this.power = 0;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
