using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_214_JA_02 : CardInfo
{
    public CardInfo_214_JA_02()
    {
        this.cardNo = "214_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "シスー";
        this.cardName2 = "神聖なる水の竜";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
