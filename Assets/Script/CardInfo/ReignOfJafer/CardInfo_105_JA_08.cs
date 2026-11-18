using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_105_JA_08 : CardInfo
{
    public CardInfo_105_JA_08()
    {
        this.cardNo = "105_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ハートの女王";
        this.cardName2 = "高慢な君主";
        this.power = 2;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.GonzaloKenny;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
