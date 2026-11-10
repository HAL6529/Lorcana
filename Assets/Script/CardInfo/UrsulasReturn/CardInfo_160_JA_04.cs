using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_04 : CardInfo
{
    public CardInfo_160_JA_04()
    {
        this.cardNo = "160_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "トリトン王";
        this.cardName2 = "若きプリンス";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
