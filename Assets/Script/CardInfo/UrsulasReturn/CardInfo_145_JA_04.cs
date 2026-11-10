using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_04 : CardInfo
{
    public CardInfo_145_JA_04()
    {
        this.cardNo = "145_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ハデス";
        this.cardName2 = "緻密な計略家";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarlosRuiz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
