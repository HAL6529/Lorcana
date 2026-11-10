using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_218_JA_04 : CardInfo
{
    public CardInfo_218_JA_04()
    {
        this.cardNo = "218_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "èóâ§";
        this.cardName2 = "êËèpét";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.noc4urne;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
