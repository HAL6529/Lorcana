using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_04 : CardInfo
{
    public CardInfo_161_JA_04()
    {
        this.cardNo = "161_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒgƒDƒNƒgƒDƒN";
        this.cardName2 = "’¿‚µ‚ª‚è‚Ì‘Š–_";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
