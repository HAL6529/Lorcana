using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_01 : CardInfo
{
    public CardInfo_090_JA_01()
    {
        this.cardNo = "090_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "マザー・ゴーテル";
        this.cardName2 = "利己的で支配的";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = "Javier Salas";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
