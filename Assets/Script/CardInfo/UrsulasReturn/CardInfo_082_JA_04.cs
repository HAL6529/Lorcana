using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_04 : CardInfo
{
    public CardInfo_082_JA_04()
    {
        this.cardNo = "082_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "パニック";
        this.cardName2 = "不死身の子分";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
