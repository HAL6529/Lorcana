using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_105_JA_01 : CardInfo
{
    public CardInfo_105_JA_01()
    {
        this.cardNo = "105_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アラジン";
        this.cardName2 = "ドブネズミ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Peter Brockhammer";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
