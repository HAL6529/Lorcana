using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_02 : CardInfo
{
    public CardInfo_174_JA_02()
    {
        this.cardNo = "174_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉxÉìÉWÉÉ";
        this.cardName2 = "ó¥ÇÃêŒÇÃéÁÇËêl";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
