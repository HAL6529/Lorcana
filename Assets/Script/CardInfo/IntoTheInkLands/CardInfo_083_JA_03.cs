using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_03 : CardInfo
{
    public CardInfo_083_JA_03()
    {
        this.cardNo = "083_JA_03";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "プリンス・ジョン";
        this.cardName2 = "バカな王様";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
