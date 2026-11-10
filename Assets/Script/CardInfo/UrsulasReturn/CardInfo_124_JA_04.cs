using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_04 : CardInfo
{
    public CardInfo_124_JA_04()
    {
        this.cardNo = "124_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉVÉXÅ[";
        this.cardName2 = "óEñ“â ä∏Ç»êÌém";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LadyShalirin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
