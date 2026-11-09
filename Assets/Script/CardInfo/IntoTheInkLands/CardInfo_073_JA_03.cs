using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_03 : CardInfo
{
    public CardInfo_073_JA_03()
    {
        this.cardNo = "073_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "タック神父";
        this.cardName2 = "ノッティンガムの司祭";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
