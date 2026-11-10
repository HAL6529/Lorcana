using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_127_JA_04 : CardInfo
{
    public CardInfo_127_JA_04()
    {
        this.cardNo = "127_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒgƒDƒNƒgƒDƒN";
        this.cardName2 = "Šˆ”­‚È‘Š–_";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SandraRios;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
