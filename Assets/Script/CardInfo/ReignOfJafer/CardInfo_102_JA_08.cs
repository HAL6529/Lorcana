using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_08 : CardInfo
{
    public CardInfo_102_JA_08()
    {
        this.cardNo = "102_JA_08";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "フリン・ライダー";
        this.cardName2 = "絶賛侵入中";
        this.power = 1;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
