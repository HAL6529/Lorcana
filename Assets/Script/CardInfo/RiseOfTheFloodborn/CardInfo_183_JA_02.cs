using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_183_JA_02 : CardInfo
{
    public CardInfo_183_JA_02()
    {
        this.cardNo = "183_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジャファー";
        this.cardName2 = "ド級の大蛇";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
